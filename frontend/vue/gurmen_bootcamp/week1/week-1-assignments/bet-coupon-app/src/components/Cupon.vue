<template>
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
  <CuponResult />
</template>

<script>
import CuponItem from './CuponItem.vue'
import CuponResult from './CuponResult.vue'
export default {
  components: {
    CuponItem,
    CuponResult,
  },
  inject: ['cupon'],
}
</script>
