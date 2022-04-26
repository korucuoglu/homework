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
        @click="cupon.betAmount = amount"
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
        <span class="font-weight-bold">{{ cupon.betAmount }} TL</span>
      </div>
      <div class="d-flex justify-content-between align-items-center mt-5">
        <span>Tahmini Kazanç</span>
        <span class="font-weight-bold text-info">{{ getTotalWin }} TL</span>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  inject: ['betAmountList', 'cupon', '$getTotalWin', '$getTotalRate'],
  computed: {
    getTotalWin() {
      return this.$getTotalWin()
    },
    getTotalRate() {
      return this.$getTotalRate()
    },
  },
}
</script>
