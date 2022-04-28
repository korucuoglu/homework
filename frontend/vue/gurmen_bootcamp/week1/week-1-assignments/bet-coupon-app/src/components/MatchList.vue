<template>
  <div class="card competition-list mr-10">
    <div class="card--header">
      <h4>Yakın Zamanda Başlayacak Müsabakalar</h4>
    </div>
    <MatchListItem v-for="match in matchList" :key="match" :match="match" />
    <Pagination @changed-page="getMatchList($event)" />
  </div>
</template>

<script>
import matchService from '../services/match'
import MatchListItem from './MatchListItem.vue'
import Pagination from './Pagination.vue'
export default {
  components: {
    MatchListItem,
    Pagination,
  },

  data() {
    return {
      matchList: [],
    }
  },

  async mounted() {
    await this.getMatchList(1)
  },

  methods: {
    async getMatchList(page) {
      this.matchList = await matchService.getAll(page)
    },
  },
}
</script>
