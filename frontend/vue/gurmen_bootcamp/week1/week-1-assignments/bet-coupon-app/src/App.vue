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
      <div class="coupon--total--container" v-show="cupon.matches.length > 0">
        <div class="card my-coupon">
          <div class="card--header">
            <h4>Kuponum</h4>
          </div>
          <div class="card--body">
            <div
              class="coupon-item"
              v-for="cupon in cupon.matches"
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
            <button
              class="btn-sm"
              v-for="item in betAmountList"
              :key="item"
              @click="cupon.betAmount = item"
            >
              {{ item }}
            </button>
          </div>
          <div class="coupon--total--container mt-20">
            <div
              class="d-flex justify-content-between align-items-center font-weight-bold"
            >
              <span>Toplam Oran</span>
              <span class="text-info">{{ cupon.totalRate.toFixed(2) }}</span>
            </div>
            <div class="d-flex justify-content-between align-items-center mt-5">
              <span>Kupon Tutarı</span>
              <span class="font-weight-bold"
                >{{ cupon.betAmount.toFixed(2) }} TL</span
              >
            </div>
            <div class="d-flex justify-content-between align-items-center mt-5">
              <span>Tahmini Kazanç</span>
              <span class="font-weight-bold text-info">{{ totalWin }} TL</span>
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
      betAmountList: [5, 10, 20, 30, 50, 100, 200, 500, 1000, 1500, 2500],

      cupon: {
        totalRate: 1.5,
        betAmount: 10,
        matches: [],
      },
    }
  },

  methods: {
    addBet(id, bet) {
      var match = this.matctList.find((x) => x.id === id)
      var newCupon = {
        matchId: match.id,
        bet: bet,
        clock: match.clock,
        result: bet === 'home' ? 1 : bet === 'away' ? 2 : 0,
        team: `${match.home} x ${match.away}`,
        rate:
          bet === 'home'
            ? match.rates.home.toFixed(2)
            : bet === 'away'
            ? match.rates.away.toFixed(2)
            : match.rates.draw.toFixed(2),
      }

      this.cupon.totalRate *= newCupon.rate
      this.cupon.totalWin = this.cupon.totalRate * this.cupon.betAmount

      this.cupon.matches.push(newCupon)
    },
    removeBet(id) {
      this.cupons = this.cupons.filter((x) => x.matchId !== id)
    },
  },

  computed: {
    totalWin() {
      return (this.cupon.totalRate * this.cupon.betAmount).toFixed(2)
    },
  },
}
</script>
