<template>
  <div class="card card-light multiply--container mt-20">
    <h4 class="text-center mb-10">Mislini Seç</h4>
    <div
      class="multiply--buttons mb-10 d-flex justify-content-center align-items-center"
    >
      <button
        class="btn-sm"
        v-for="amount in betAmountList"
        :key="amount"
        @click="changeAmount(amount)"
      >
        {{ amount }}
      </button>
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
        <span class="font-weight-bold">{{ _betAmount }} TL</span>
      </div>
      <div class="d-flex justify-content-between align-items-center mt-5">
        <span>Tahmini Kazanç</span>
        <span class="font-weight-bold text-info">{{ getTotalWin }} TL</span>
      </div>
    </div>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
export default {
  data() {
    return {
      betAmountList: [5, 10, 20, 30, 50, 100, 200, 500, 1000, 1500, 2500],
    }
  },

  methods: {
    changeAmount(number) {
      this.$store.commit('changeBetAmount', number)
    },
  },

  computed: {
    ...mapGetters(['_betAmount', '_matches']),
    getTotalWin() {
      return (this.getTotalRate * this._betAmount).toFixed(2)
    },

    getTotalRate() {
      if (this._matches.length > 0) {
        var number = this._matches
          .map((x) => x.rate)
          .reduce((pre, next) => pre * next)
        return (Math.round(number * 100) / 100).toFixed(2)
      }
      return 0
    },
  },
}
</script>
