<template>
  <header>Bet Coupon App</header>
  <div class="container">
    <div
      class="bet--coupon--app d-flex justify-content-between align-items-start"
    >
      <!-- Mac Listesi-->
      <MatcList :matctList="provideData.matctList" />
      <!-- Kuponum -->
      <div
        class="coupon--total--container"
        v-if="provideData.cupon.matches.length > 0"
      >
        <Cupon />
      </div>
    </div>
  </div>
</template>

<script>
import MatcList from './components/MatchList.vue'
import Cupon from './components/Cupon.vue'
export default {
  components: {
    MatcList,
    Cupon,
  },
  provide() {
    return {
      betAmountList: this.provideData.betAmountList,
      addBet: this.addBet,
      cupon: this.provideData.cupon,
      $totalWin: () => this.totalWin,
    }
  },
  data() {
    return {
      provideData: {
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
          matches: [
            {
              matchId: 1,
              bet: 'bet',
              clock: '19.00',
              result: 1,
              team: 'Galatasaray x Fenerbahçe',
              rate: 1.5,
            },
          ],
        },
      },
    }
  },

  methods: {
    addBet(id, bet) {
      var match = this.provideData.matctList.find((x) => x.id === id)
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

      this.provideData.cupon.totalRate *= newCupon.rate
      this.provideData.cupon.totalWin =
        this.provideData.cupon.totalRate * this.provideData.cupon.betAmount

      this.provideData.cupon.matches.push(newCupon)
    },
    removeBet(id) {
      this.provideData.cupons = this.provideData.cupons.filter(
        (x) => x.matchId !== id
      )
    },
  },

  computed: {
    totalWin() {
      return (
        this.provideData.cupon.totalRate * this.provideData.cupon.betAmount
      ).toFixed(2)
    },
  },
}
</script>
