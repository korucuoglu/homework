<template>
  <header>Bookmark App</header>
  <div class="container">
    <div class="bookmark--app--container">
      <BookmarkList :bookmarks="bookmarks" />
    </div>
  </div>
</template>

<script>
import BookmarkList from './components/BookmarkList.vue'
export default {
  components: {
    BookmarkList,
  },
  data() {
    return {
      edit: false,
      bookmarks: [
        {
          title: 'Google',
          description: 'Her şeyi bulabileceğiniz arama motoru',
          url: 'https://www.google.com',
        },
        {
          title: 'Deneme 1',
          description: 'Açıklama',
          url: 'https://www.google.com',
          edit: false,
        },
        {
          title: 'Deneme 2',
          description: 'Açıklama',
          url: 'https://www.google.com',
          edit: false,
        },
        {
          title: 'Deneme 3',
          description: 'Açıklama',
          url: 'https://www.google.com',
          edit: false,
        },
        {
          title: 'Deneme 4',
          description: 'Açıklama',
          url: 'https://www.google.com',
          edit: false,
        },
      ],
    }
  },

  methods: {
    deleteBookmark(bookmark) {
      this.bookmarks = this.bookmarks.filter((x) => x !== bookmark)
    },
    directUrl(url) {
      window.open(url, '_blank')
    },
  },

  provide() {
    return {
      deleteBookmark: this.deleteBookmark,
      directUrl: this.directUrl,
    }
  },
}
</script>
