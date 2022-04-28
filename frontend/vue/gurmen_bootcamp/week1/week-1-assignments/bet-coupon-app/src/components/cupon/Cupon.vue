<template>
  <div v-if="cupon.matches.length > 0">
    <div class="card my-coupon">
      <div class="card--header">
        <h4>Kuponum</h4>
      </div>
      <div class="card--body">
        <CuponItem
          v-for="match in cupon.matches"
          :key="match.id"
          :match="match"
        />
      </div>
    </div>
    <CuponResult :cupon="cupon" />
  </div>
</template>

<script>
import matchService from '../../services/match'
import CuponItem from '../cupon/CuponItem.vue'
import CuponResult from '../cupon/CuponResult.vue'
export default {
  components: {
    CuponItem,
    CuponResult,
  },

  provide() {
    return {
      addBet: this.addBet,
    }
  },

  data() {
    return {
      cupon: {
        betAmount: 5,
        matches: [],
      },
    }
  },

  methods: {
    async addBet(id, bet) {
      if (this.cupon.matches.some((x) => x.matchId === id)) {
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
      this.cupon.matches.push(newCupon)
    },
  },
}
</script>
