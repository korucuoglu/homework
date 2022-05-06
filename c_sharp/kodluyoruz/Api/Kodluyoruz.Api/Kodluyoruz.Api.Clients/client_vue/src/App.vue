<template>
  <div class="container mt-5">
    <div class="row">
      <div class="col-6 offset-3">
        <div class="mb-5">
          <label class="form-label">Yeni Ürün</label>
          <input type="text" class="form-control" @keydown.enter="addItem" />
        </div>
        <table class="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Ürün Adı</th>
              <th scope="col">Actions</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="item in itemList" :key="item.id">
              <td>{{ item.id }}</td>
              <td>{{ item.name }}</td>
              <td>
                <button
                  class="btn btn-sm btn-danger me-2"
                  @click="deleteItem(item.id)"
                >
                  Sil
                </button>

                <button
                  class="btn btn-sm btn-warning"
                  @click="deleteItem(item.id)"
                >
                  Güncelle
                </button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'App',
  data() {
    return {
      itemList: [],
    }
  },

  methods: {
    deleteItem(id) {
      axios.delete(`http://localhost:5000/api/product/${id}`).then(() => {
        this.itemList = this.itemList.filter((x) => x.id !== id)
      })
    },

    addItem(e) {
      const itemName = e.target.value
      axios
        .post('http://localhost:5000/api/product', { name: itemName })
        .then((response) => {
          this.itemList.push({ id: response.data, name: itemName })
        })
      e.target.value = ''
    },
  },

  mounted() {
    axios.get('http://localhost:5000/api/product').then((response) => {
      this.itemList = response.data
    })
  },
}
</script>
