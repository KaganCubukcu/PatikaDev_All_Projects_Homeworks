const posts = [
  { name: "İzmir", author: "Author 1" },
  { name: "Ankara", author: "Author 2" },
  { name: "İstanbul", author: "Author 3" },
];
const listPosts = () => {
  posts.map((post) => {
    console.log(post.name);
  });
};

const addPost = (newPost) => {
  return new Promise((res, rej) => {
    try {
      posts.push(newPost);
      res(posts);
    } catch (err) {
      rej(err);
    }
  });
};

async function process() {
  const newPost = { name: "Aydın", author: "Author 4" };
  try {
    await addPost(newPost);
    await listPosts();
    console.log("Yeni post başarılı bir şekilde eklendi");
  } catch (err) {
    console.log(err);
  }
}
process();
