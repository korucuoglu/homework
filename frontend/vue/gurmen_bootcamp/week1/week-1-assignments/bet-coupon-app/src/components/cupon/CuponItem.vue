<template>
  <div class="coupon-item">
    <div class="w-100 mb-5 d-flex justify-content-between align-items-center">
      <span class="font-weight-bold">{{ match.team }}</span>
      <span class="font-weight-bold text-info">{{ match.rate }}</span>
    </div>
    <div class="w-100 d-flex justify-content-between align-items-center">
      <small class="mt-5"
        >Maç Sonucu:
        <span class="font-weight-bold">{{ getResult }}</span></small
      >
      <small class="text-muted">Saat : {{ match.clock }}</small>
    </div>
  </div>
</template>

<script>
export default {
  props: ['match'],
  computed: {
    getResult() {
      return this.match.bet === 'home' ? 1 : this.match.bet === 'away' ? 2 : 0
    },
  },
}
</script>
