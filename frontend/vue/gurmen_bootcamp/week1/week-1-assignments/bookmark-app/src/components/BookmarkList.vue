<template>
  <div class="bookmark-item" v-for="bookmark in bookmarks" :key="bookmark">
    <!-- EDİT  -->
    <div v-if="bookmark.edit">
      <BookmarkListEditItem :item="bookmark" />
    </div>
    <!-- SAVE  -->
    <div v-else>
      <BookmarkListItem :item="bookmark" />
    </div>
  </div>
</template>

<script>
import BookmarkListEditItem from './BookmarkListEditItem.vue'
import BookmarkListItem from './BookmarkListItem.vue'
export default {
  components: {
    BookmarkListEditItem,
    BookmarkListItem,
  },
  props: ['bookmarks'],
}
</script>
