<template class="vh-100" style="background-color: #eee">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-lg-9 col-xl-7">
        <div class="card rounded-3">
          <div class="card-body p-4">
            <h4 class="text-center my-3 pb-3">To Do App</h4>

            <form
              class="row row-cols-lg-auto g-3 justify-content-center align-items-center mb-4 pb-2"
            >
              <div class="col-12">
                <AddSection />
              </div>
            </form>

            <table class="table mb-4">
              <thead>
                <tr>
                  <th scope="col">No.</th>
                  <th scope="col">Todo item</th>
                  <th scope="col">Status</th>
                  <th scope="col">Actions</th>
                </tr>
              </thead>
              <tbody>
                <TodoList />
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import AddSection from './components/AddSection.vue'
import TodoList from './components/TodoList.vue'
export default {
  components: {
    AddSection,
    TodoList,
  },

  provide() {
    return {
      addTodo: this.addTodo,
      deleteTodo: this.deleteTodo,
      provideData: this.provideData,
    }
  },

  data() {
    return {
      provideData: {
        todoList: [
          {
            Id: 1,
            text: 'deneme 1',
            completed: false,
          },
        ],
      },
    }
  },

  methods: {
    addTodo(event) {
      this.provideData.todoList.push({
        Id: Math.floor(Math.random() * 100),
        text: event.target.value,
        completed: false,
      })
      event.target.value = ''
    },

    deleteTodo(todo) {
      this.provideData.todoList = this.provideData.todoList.filter(
        (x) => x !== todo
      )
    },
  },
}
</script>
