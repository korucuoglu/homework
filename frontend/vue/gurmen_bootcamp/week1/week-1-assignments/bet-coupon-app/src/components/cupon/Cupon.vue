<template>
  <div v-if="_matches.length > 0">
    <div class="card my-coupon">
      <div class="card--header">
        <h4>Kuponum</h4>
      </div>
      <div class="card--body">
        <CuponItem v-for="match in _matches" :key="match.id" :match="match" />
      </div>
    </div>
    <CuponResult />
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
import CuponItem from '../cupon/CuponItem.vue'
import CuponResult from '../cupon/CuponResult.vue'
export default {
  components: {
    CuponItem,
    CuponResult,
  },

  computed: {
    ...mapGetters(['_matches']),
  },
}
</script>
