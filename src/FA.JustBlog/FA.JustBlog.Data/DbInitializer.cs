using FA.JustBlog.Models.Common;
using FA.JustBlog.Models.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Data
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<JustBlogDbContext>
    {
        protected override void Seed(JustBlogDbContext context)
        {
            InitializeIdentity(context);
            var categories = new List<Category>
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Technology",
                    UrlSlug = "technology",
                    Description ="This category is for posts about Technology blogs!",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Game Online",
                    UrlSlug = "game-online",
                    Description ="This category is for posts about Game Online blogs!",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Health",
                    UrlSlug = "health",
                    Description ="This category is for about Health blogs!",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Life Style",
                    UrlSlug = "life-style",
                    Description ="This category is for posts about food!",
                    IsDeleted = false
                }
            };

            var tags = new List<Tag>
            {
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "technology",
                    UrlSlug = "technology",
                    Description = "This tag is for attaching to posts about technology",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "health",
                    UrlSlug = "health",
                    Description = "This tag is for attaching to posts about health",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "drama",
                    UrlSlug = "recipe",
                    Description = "This tag is for attaching to posts about drama",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "tips",
                    UrlSlug = "tips",
                    Description = "This tag is for attaching to posts about tips",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "game online",
                    UrlSlug = "game-online",
                    Description = "This tag is for attaching to posts about game online",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "life style",
                    UrlSlug = "life-style",
                    Description = "This tag is for attaching to posts about life style",
                    IsDeleted = false
                },

                new Tag
                {
                    Id = Guid.NewGuid(),
                    Name = "setup",
                    UrlSlug = "setup",
                    Description = "This tag is for attaching to posts about setup",
                    IsDeleted = false
                }
            };

            var posts = new List<Post>
            {
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "CPU Alder Lake thế hệ thứ 12 thách thức nhiều đối thủ cạnh tranh",
                    UrlSlug = "cpu-alder-lake-the-he-thu-12-thach-thuc-nhieu-doi-thu-canh-tranh",
                    ShortDescription = "Trong sự kiện virtual Architecture Day, Intel đã công bố thế hệ CPU thứ 12 mới nhất.",
                    ImageUrl = "blog-1.jpg",
                    PostContent = "Bộ vi xử lý Alder Lake sẽ có lõi công xuất cao được gọi là lõi hiệu suất" +
                    " và lõi được cấp nguồn thấp được gọi là lõi hiệu quả (gọi tắt là lõi P và lõi E).",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Technology")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("technology")),
                        tags.Single(x => x.Name.Equals("life style"))
                    }
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Bị tố “lừa tiền, lừa tình” nam streamer bức xúc đôi co trên sóng livestream",
                    UrlSlug = "bi-to-lua-tien-lua-tinh-nam-streamer-buc-xuc-doi-co-tren-song-livestream",
                    ShortDescription = "Nổi lên trong cộng đồng Liên quân Mobile, LazyBoy là một trong những streamer nam có lượng fan đông đảo.",
                    ImageUrl = "blog-2.jpg",
                    PostContent = "Sau một thời gian im ắng, yên bình với sự nghiệp cống hiến cho game và livestream của mình " +
                    "thì cách đây vài giờ đồng hồ, anh chàng này trở thành tâm điểm của các cuộc bàn tán khi bị gái xinh tố lừa đảo " +
                    "(lừa tình, lừa tiền); “bắt cá nhiều tay”, lợi dụng xong thì đá như bao cát như chưa từng quen; chiếm đoạt tiền của fan nữ,…",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Game Online")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("drama")),
                        tags.Single(x => x.Name.Equals("game online"))
                    }
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "TP.HCM tiếp nhận 10 xe xét nghiệm COVID-19 lưu động do doanh nghiệp trao tặng",
                    UrlSlug = "tp-hcm-tiep-nhan-10-xe-xet-nghiem-covid-19-luu-dong-do-doanh-nghiep-trao-tang",
                    ShortDescription = "Được biết 10 xe xét nghiệm này do Ngân hàng TMCP Sài Gòn (SCB) và Tập đoàn Vạn Thịnh Phát trao tặng.",
                    ImageUrl = "blog-4.jpg",
                    PostContent = "GS.TS Phan Trọng Lân – viện trưởng Viện Pasteur TP.HCM – cho biết " +
                    "đơn vị được giao tiếp nhận 10 xe xét nghiệm lưu động do Ngân hàng SCB và các đối tác tài trợ, " +
                    "đồng thời thực hiện đào tạo tập huấn nguồn nhân lực để triển khai xét nghiệm lưu động trên địa bàn.",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Health")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("life style")),
                        tags.Single(x => x.Name.Equals("health"))
                    }
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Redmi Note 8 cập nhật MIUI 12.5 và Android 11",
                    UrlSlug = "redmi-note-8-cap-nhat-miui-12-5-va-android-11",
                    ShortDescription = "Redmi Note 8 đã bắt đầu được cập nhật MIUI 12.5 dựa trên Android 11.",
                    ImageUrl = "blog-3.jpg",
                    PostContent = "Xiaomi đang tung ra bản cập nhật MIUI 12.5 dành cho Redmi Note 8. " +
                    "Bản cập nhật hiện đang được triển khai tại Trung Quốc với số bản dựng V12.5.1.0.RCOCNXM. " +
                    "Dường như bản cập nhật đang được tung theo đợt, nên chỉ có một số ít người dùng nhận được thông báo cập nhật.",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Technology")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("technology")),
                        tags.Single(x => x.Name.Equals("life style"))
                    }
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Phần mềm quay phim màn hình đơn giản CamStudio",
                    UrlSlug = "phan-mem-quay-phim-man-hinh-don-gian-camstudio",
                    ShortDescription = "Với việc hướng dẫn các Tut trên máy tính thì" +
                    " một phần mềm quay phim màn hình là rất cần thiết.",
                    ImageUrl = "blog-6.jpg",
                    PostContent = "Thay vì phải cung cấp một chuỗi toàn bộ ảnh chụp màn hình với văn bản giải thích liên quan," +
                    " một video clip duy nhất có thể làm tất cả. Ngoài  ghi lại thao tác trên màn hình," +
                    " video của bạn có thể bao gồm âm thanh bình luận hoặc," +
                    " nếu bạn thích, trên màn hình chú thích hoặc chú thích để giải thích những gì bạn đang làm.",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Technology")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("tips")),
                        tags.Single(x => x.Name.Equals("technology")),
                        tags.Single(x => x.Name.Equals("setup"))
                    }
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Rắn Săn Mồi và những tựa game mobile đời đầu tại Việt Nam",
                    UrlSlug = "ran-san-moi-va-nhung-tua-game-mobile-doi-dau-tai-viet-nam",
                    ShortDescription = "Tựa game mobile kinh điển của giới game thủ Việt chắc chắn chính là cái tên Rắn Săn Mồi.",
                    ImageUrl = "blog-5.jpg",
                    PostContent = "Tựa game Rắn Săn Mồi là một trong những game mobile đầu tiên trên thế giới khi ra mắt vào năm 1997. " +
                    "Luật chơi rất đơn giản, chỉ cần điều khiển những chú rắn di chuyển ăn hết thức ăn trên đường " +
                    "mà không đụng vào tường hay chính cơ thể của mình là đủ để qua bàn.",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Find(x => x.Name.Equals("Life Style")),
                    Tags = new List<Tag>
                    {
                        tags.Single(x => x.Name.Equals("setup")),
                        tags.Single(x => x.Name.Equals("life style"))
                    }
                }
            };

            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.SaveChanges();
        }
        public static void InitializeIdentity(JustBlogDbContext db)
        {
            var userManager = new UserManager<User>(new UserStore<User>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            const string name = "admin@example.com";
            const string password = "Admin@123456";
            const string roleName = "Admin";

            //Create Role Admin if it does not exist
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new IdentityRole(roleName);
                var roleResult = roleManager.Create(role);
            }

            var user = userManager.FindByName(name);
            if (user == null)
            {
                user = new User { UserName = name, Email = name };
                var result = userManager.Create(user, password);
                result = userManager.SetLockoutEnabled(user.Id, false);
            }

            // Add user admin to Role Admin if not already added
            var rolesForUser = userManager.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                var result = userManager.AddToRole(user.Id, role.Name);
            }
        }
    }
}
