<template>
  <div class="comment--like--dislike--app">
    <CommentListItem v-for="item in items" :key="item" :item="item" />
  </div>
</template>

<script>
import CommentListItem from './CommentListItem.vue'
export default {
  components: {
    CommentListItem,
  },
  props: ['items'],
}
</script>
