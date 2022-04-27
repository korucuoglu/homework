<template>
  <header>Bet Coupon App</header>
  <div class="container">
    <div
      class="bet--coupon--app d-flex justify-content-between align-items-start"
    >
      <!-- Mac Listesi-->
      <MatcList :matchList="provideData.matchList" />
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
import matchService from './services/match'
export default {
  components: {
    MatcList,
    Cupon,
  },

  provide() {
    return {
      betAmountList: this.provideData.betAmountList,
      getMatchList: this.getMatchList,
      addBet: this.addBet,
      cupon: this.provideData.cupon,
      $getTotalWin: () => this.getTotalWin,
      $getTotalRate: () => this.getTotalRate,
      pageData: this.provideData.pageData,
    }
  },
  data() {
    return {
      provideData: {
        matchList: [],
        betAmountList: [5, 10, 20, 30, 50, 100, 200, 500, 1000, 1500, 2500],
        cupon: {
          betAmount: 5,
          matches: [],
        },
        pageData: {
          currentPage: 1,
          endPage: 8,
        },
      },
    }
  },

  async mounted() {
    await this.getMatchList(1)
  },

  methods: {
    async addBet(id, bet) {
      if (this.provideData.cupon.matches.some((x) => x.matchId === id)) {
        return
        // this.provideData.cupon.matches = this.provideData.cupon.matches.filter(
        //   (x) => x.matchId !== id
        // )
      }
      var match = await matchService.getById(id)
      var newCupon = {
        matchId: match.id,
        bet: bet,
        clock: match.clock,
        result: bet === 'home' ? 1 : bet === 'away' ? 2 : 0,
        team: `${match.home} x ${match.away}`,
        rate:
          bet === 'home'
            ? match.rates.home
            : bet === 'away'
            ? match.rates.away
            : match.rates.draw,
      }
      this.provideData.cupon.matches.push(newCupon)
    },
    removeBet(id) {
      this.provideData.cupon.matches = this.provideData.cupon.matches.filter(
        (x) => x.id !== id
      )
    },
    async getMatchList(page) {
      this.provideData.pageData.currentPage = page
      this.provideData.matchList = await matchService.getAll(page)
    },
  },

  computed: {
    getTotalWin() {
      return (this.getTotalRate * this.provideData.cupon.betAmount).toFixed(2)
    },

    getTotalRate() {
      if (this.provideData.cupon.matches.length > 0) {
        var number = this.provideData.cupon.matches
          .map((x) => x.rate)
          .reduce((pre, next) => pre * next)
        return (Math.round(number * 100) / 100).toFixed(2)
      }
      return 0
    },
  },
}
</script>
