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
import axios from 'axios'
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
      $getTotalWin: () => this.getTotalWin,
      $getTotalRate: () => this.getTotalRate,
    }
  },
  data() {
    return {
      provideData: {
        matctList: [],
        betAmountList: [5, 10, 20, 30, 50, 100, 200, 500, 1000, 1500, 2500],
        cupon: {
          betAmount: 5,
          matches: [],
        },
      },
    }
  },

  mounted() {
    axios.get('http://localhost:3000/data').then((response) => {
      this.provideData.matctList = response.data.map((match) => {
        return {
          id: match.MatchID,
          home: match.takim1,
          away: match.takim2,
          clock: match.Saat,
          rates: {
            home: match.ms1,
            draw: match.ms0,
            away: match.ms2,
          },
        }
      })

      console.log(response.data)
    })
  },

  methods: {
    addBet(id, bet) {
      if (this.provideData.cupon.matches.some((x) => x.matchId === id)) {
        this.provideData.cupon.matches = this.provideData.cupon.matches.filter(
          (x) => x.matchId !== id
        )
      }

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
      this.provideData.cupon.matches.push(newCupon)
    },
    removeBet(id) {
      this.provideData.cupon = this.provideData.cupon.matches.filter(
        (x) => x.id !== id
      )
    },
  },

  computed: {
    getTotalWin() {
      return (this.getTotalRate * this.provideData.cupon.betAmount).toFixed(2)
    },

    getTotalRate() {
      if (this.provideData.cupon.matches.length > 0) {
        var mapperData = this.provideData.cupon.matches.map((x) => x.rate)
        return mapperData.reduce((pre, next) => pre * next)
      }

      return 0
    },
  },
}
</script>
