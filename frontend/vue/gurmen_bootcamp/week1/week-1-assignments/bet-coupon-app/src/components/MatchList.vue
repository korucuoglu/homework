<template>
  <div class="card competition-list mr-10">
    <div class="card--header">
      <h4>Yakın Zamanda Başlayacak Müsabakalar</h4>
    </div>
    <MatchListItem v-for="match in matchList" :key="match" :match="match" />
    <Pagination />
  </div>
</template>

<script>
import MatchListItem from './MatchListItem.vue'
import Pagination from './Pagination.vue'
export default {
  components: {
    MatchListItem,
    Pagination,
  },
  props: ['matchList'],
}
</script>
