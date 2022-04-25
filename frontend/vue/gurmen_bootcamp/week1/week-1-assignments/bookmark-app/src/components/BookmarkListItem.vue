<template>
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
    <button class="btn-warning btn-sm" @click="bookmark.edit = !bookmark.edit">
      Edit
    </button>
  </div>
</template>

<script>
export default {
  props: ['item'],
  inject: ['deleteBookmark', 'directUrl'],
  data() {
    return {
      bookmark: this.item,
    }
  },
}
</script>
