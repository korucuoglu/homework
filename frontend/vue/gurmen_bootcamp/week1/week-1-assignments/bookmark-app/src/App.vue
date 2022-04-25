<template>
  <header>Bookmark App</header>
  <div class="container">
    <div class="bookmark--app--container">
      <div class="bookmark-item" v-for="bookmark in bookmarks" :key="bookmark">
        <!-- EDİT  -->
        <div v-if="bookmark.edit">
          <div class="form-group">
            <input v-model="bookmark.title" />
            <input v-model="bookmark.url" />
            <textarea v-model="bookmark.description" />
          </div>

          <div class="d-flex align-items-center justify-content-between">
            <button class="btn-primary btn-sm" @click="bookmark.edit = false">
              Kaydet
            </button>
          </div>
        </div>

        <!-- SAVE  -->
        <div v-else>
          <div class="header">
            <h3>{{ bookmark.title }}</h3>
            <button class="btn-sm btn-danger" @click="deleteBookmark(bookmark)">
              Kaydı Sil
            </button>
          </div>
          <p class="mt-20 mb-20">{{ bookmark.description }}</p>
          <div class="d-flex align-items-center justify-content-between">
            <button class="btn-primary btn-sm" @click="directUrl(bookmark.url)">
              Göster
            </button>
            <button
              class="btn-warning btn-sm"
              @click="bookmark.edit = !bookmark.edit"
            >
              Edit
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
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
}
</script>
