<template>
  <div class="card--body">
    <div class="competition-item">
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
</template>

<script>
import matchService from '../../services/match'
export default {
  components: {},
  props: ['match'],

  methods: {
    async addBet(id, bet) {
      var match = await matchService.getById(id)
      var matchFromCupon = {
        matchId: match.id,
        bet: bet,
        clock: match.clock,
        team: `${match.home} x ${match.away}`,
        rate:
          bet === 'home'
            ? match.rates.home
            : bet === 'away'
            ? match.rates.away
            : match.rates.draw,
      }
      this.$store.commit('addMatchtoCupon', matchFromCupon)
    },
  },
}
</script>
