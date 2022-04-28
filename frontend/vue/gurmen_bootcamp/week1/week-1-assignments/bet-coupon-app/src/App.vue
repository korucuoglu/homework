<template>
  <header>Bet Coupon App</header>
  <div class="container">
    <div
      class="bet--coupon--app d-flex justify-content-between align-items-start"
    >
      <!-- Mac Listesi-->
      <MatcList />
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
      addBet: this.addBet,
      cupon: this.provideData.cupon,
    }
  },
  data() {
    return {
      provideData: {
        cupon: {
          betAmount: 5,
          matches: [],
        },
      },
    }
  },

  methods: {
    async addBet(id, bet) {
      if (this.provideData.cupon.matches.some((x) => x.matchId === id)) {
        return
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
  },
}
</script>
