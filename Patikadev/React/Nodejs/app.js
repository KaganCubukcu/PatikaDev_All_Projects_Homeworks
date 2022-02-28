import axios from "axios";

async function getData(id) {
  const { data: users } = await axios(
    `https://jsonplaceholder.typicode.com/users/${id}`
  );
  const { data: post1 } = await axios(
    `https://jsonplaceholder.typicode.com/posts?userId=${id}`
  );
  console.log("users", users);
  console.log("post1", post1);
}
getData(1);
