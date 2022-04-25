<template>
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
</template>

<script>
export default {
  props: ['item'],
  data() {
    return {
      bookmark: this.item,
    }
  },
}
</script>
