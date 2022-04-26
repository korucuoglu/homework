<template>
  <header>Bet Coupon App</header>
  <div class="container">
    <div
      class="bet--coupon--app d-flex justify-content-between align-items-start"
    >
      <!-- Mac Listesi-->
      <div class="card competition-list mr-10">
        <div class="card--header">
          <h4>Yakın Zamanda Başlayacak Müsabakalar</h4>
        </div>
        <div class="card--body">
          <div
            class="competition-item"
            v-for="match in matctList"
            :key="match.id"
          >
            <div class="info--container">
              <span class="font-weight-bold"
                >{{ match.home }} x {{ match.away }}</span
              >
              <small class="text-muted mt-5"
                ><i>Saat : {{ match.clock }}</i></small
              >
            </div>
            <div class="rates">
              <div class="rate-item">
                <button class="btn-sm" @click="addBet(match.id, 'home')">
                  {{ match.rates.home }}
                </button>
              </div>
              <div class="rate-item">
                <button class="btn-sm" @click="addBet(match.id, 'draw')">
                  {{ match.rates.draw }}
                </button>
              </div>
              <div class="rate-item">
                <button class="btn-sm" @click="addBet(match.id, 'away')">
                  {{ match.rates.away }}
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- Kuponum -->
      <div class="coupon--total--container">
        <div class="card my-coupon">
          <div class="card--header">
            <h4>Kuponum</h4>
          </div>
          <div class="card--body">
            <div
              class="coupon-item"
              v-for="cupon in GetCuponDetails"
              :key="cupon.id"
            >
              <div
                class="w-100 mb-5 d-flex justify-content-between align-items-center"
              >
                <span class="font-weight-bold">{{ cupon.team }}</span>
                <span class="font-weight-bold text-info">{{ cupon.rate }}</span>
              </div>
              <div
                class="w-100 d-flex justify-content-between align-items-center"
              >
                <small class="mt-5"
                  >Maç Sonucu:
                  <span class="font-weight-bold">{{
                    cupon.result
                  }}</span></small
                >
                <small class="text-muted">Saat : {{ cupon.clock }}</small>
              </div>
            </div>
          </div>
        </div>
        <div class="card card-light multiply--container mt-20">
          <h4 class="text-center mb-10">Mislini Seç</h4>
          <div
            class="multiply--buttons mb-10 d-flex justify-content-center align-items-center"
          >
            <button class="btn-sm">5</button>
            <button class="btn-sm">10</button>
            <button class="btn-sm">20</button>
            <button class="btn-sm">30</button>
            <button class="btn-sm">50</button>
            <button class="btn-sm">100</button>
            <button class="btn-sm">200</button>
            <button class="btn-sm">500</button>
            <button class="btn-sm">1000</button>
            <button class="btn-sm">1500</button>
            <button class="btn-sm">2500</button>
          </div>
          <div class="coupon--total--container mt-20">
            <div
              class="d-flex justify-content-between align-items-center font-weight-bold"
            >
              <span>Toplam Oran</span>
              <span class="text-info">{{ getTotalRate }}</span>
            </div>
            <div class="d-flex justify-content-between align-items-center mt-5">
              <span>Kupon Tutarı</span>
              <span class="font-weight-bold">10,00 TL</span>
            </div>
            <div class="d-flex justify-content-between align-items-center mt-5">
              <span>Tahmini Kazanç</span>
              <span class="font-weight-bold text-info">450,00 TL</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      matctList: [
        {
          id: 1,
          home: 'Galatasaray',
          away: 'Fenerbahçe',
          clock: '19:00',
          rates: {
            home: 1.5,
            draw: 3.2,
            away: 2.8,
          },
        },
        {
          id: 2,
          home: 'Başakşehir',
          away: 'Beşiktaş',
          clock: '21:00',
          rates: {
            home: 2.8,
            draw: 3.1,
            away: 2.1,
          },
        },
      ],
      cupons: [{ id: '100', matchId: 1, bet: 'home' }],
    }
  },

  methods: {
    addBet(id, bet) {
      this.cupons.push({ id: new Date().getTime(), matchId: id, bet: bet })
    },
    removeBet(id) {
      this.cupons = this.cupons.filter((x) => x.matchId !== id)
    },
  },

  computed: {
    GetCuponDetails() {
      var result = this.cupons.map((cupon) => {
        var match = this.matctList.find((x) => x.id === cupon.matchId)
        return {
          id: cupon.id,
          matchId: match.id,
          clock: match.clock,
          team: `${match.home} x ${match.away}`,
          result: cupon.bet === 'home' ? 1 : cupon.bet === 'away' ? 2 : 0,
          rate:
            cupon.bet === 'home'
              ? match.rates.home
              : cupon.bet === 'away'
              ? match.rates.away
              : match.rates.draw,
        }
      })
      return result
    },

    getTotalRate() {
      var rates = this.GetCuponDetails.map((x) => x.rate)
      return rates.reduce((sum, current) => sum * current).toFixed(2)
    },
  },
}
</script>
