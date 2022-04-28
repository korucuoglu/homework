<template>
  <header>Bet Coupon App</header>
  <div class="container">
    <div
      class="bet--coupon--app d-flex justify-content-between align-items-start"
    >
      <!-- Mac Listesi-->
      <MatcList />
      <!-- Kuponum -->
      <div class="coupon--total--container">
        <Cupon />
      </div>
    </div>
  </div>
</template>

<script>
import MatcList from './components/match/MatchList.vue'
import Cupon from './components/cupon/Cupon.vue'
export default {
  components: {
    MatcList,
    Cupon,
  },
}
</script>
