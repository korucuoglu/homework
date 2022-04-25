<template>
  <div class="user--action--container">
    <div class="form-group">
      <label>Kursun Adı</label>
      <input
        type="text"
        v-model="title"
        @keydown.enter="$emit('add-course', title)"
      />
    </div>
    <button class="btn-primary" @click="$emit('add-course', title)">
      Kurs Ekle
    </button>
  </div>
</template>

<script>
export default {}
</script>
