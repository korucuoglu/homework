<template>
  <div class="card competition-list mr-10">
    <div class="card--header">
      <h4>Yakın Zamanda Başlayacak Müsabakalar</h4>
    </div>
    <MatchListItem v-for="match in matctList" :key="match" :match="match" />
  </div>
</template>

<script>
import MatchListItem from './MatchListItem.vue'
export default {
  components: {
    MatchListItem,
  },
  props: ['matctList'],
}
</script>
