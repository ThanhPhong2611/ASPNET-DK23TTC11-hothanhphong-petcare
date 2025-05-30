﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopProj.Data;

#nullable disable

namespace PetShopProj.Migrations
{
    [DbContext(typeof(PetDbContext))]
    partial class PetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<string>", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser<string>");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("PetShopProj.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            CategoryId = 1,
                            Description = "The cow, in common parlance, a domestic bovine, regardless of sex and age, usually of the species Bos taurus. In precise usage, the name is given to mature females of several large mammals, including cattle (bovines), moose, elephants, sea lions, and whales.",
                            Name = "Cow",
                            PicturePath = "d2326411-92ec-4698-a1b2-0cbad507ae08_cow.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Age = 12,
                            CategoryId = 1,
                            Description = "The tiger (Panthera tigris) is the largest living cat species and a member of the genus Panthera. It is most recognisable for its dark vertical stripes on orange fur with a white underside. An apex predator, it primarily preys on ungulates, such as deer and wild boar. It is territorial and generally a solitary but social predator, requiring large contiguous areas of habitat to support its requirements for prey and rearing of its offspring.",
                            Name = "Tiger",
                            PicturePath = "715fcda7-488b-4fce-831f-322a4bc5e624_tiger.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Age = 8,
                            CategoryId = 1,
                            Description = "The lion (Panthera leo) is a large cat of the genus Panthera native to Africa and India. It has a muscular, broad-chested body, short, rounded head, round ears, and a hairy tuft at the end of its tail. It is sexually dimorphic; adult male lions are larger than females and have a prominent mane. It is a social species, forming groups called prides. A lion's pride consists of a few adult males, related females, and cubs.",
                            Name = "Lion",
                            PicturePath = "adbbb496-9b17-4c1f-8cbc-5943dd7c964e_lion.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Age = 4,
                            CategoryId = 2,
                            Description = "The true finches are small to medium-sized birds in the family Fringillidae. Finches have stout conical bills adapted for eating seeds and nuts and often have colourful plumage. They occupy a great range of habitats where they are usually resident and do not migrate. They have a worldwide distribution except for Australia and the polar regions. The family Fringillidae contains more than two hundred species divided into fifty genera.",
                            Name = "Finch",
                            PicturePath = "f94ca42a-e0a3-4d3e-b0ef-81c0e31588f2_finch.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Age = 18,
                            CategoryId = 2,
                            Description = "The cockatiel (kɒkəˈtiːl) Nymphicus hollandicus), also known as weiro, or quarrion, is a medium-sized parrot that is a member of its own branch of the cockatoo family endemic to Australia. They are prized as household pets and companion parrots throughout the world and are relatively easy to breed. As a caged bird, cockatiels are second in popularity only to the budgerigar.",
                            Name = "Cocktail",
                            PicturePath = "a6b31533-7662-4b95-beec-8c605145f6cb_cocktail.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Age = 5,
                            CategoryId = 4,
                            Description = "The Siamese fighting fish (Betta splendens), commonly known as the betta, is a freshwater fish native to Southeast Asia, namely Cambodia, Laos, Myanmar, Malaysia, Indonesia, Thailand, and Vietnam. It is one of 73 species of the genus Betta, but the only one eponymously called \"betta\", owing to its global popularity as a pet; Betta splendens are among the most popular aquarium fish in the world, due to their diverse and colorful morphology and relatively low maintenance.",
                            Name = "Fighting Fish",
                            PicturePath = "63bb0350-8337-46a8-b7a6-3bcc4227618e_Fighting-Fish.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Age = 3,
                            CategoryId = 4,
                            Description = "The goldfish (Carassius auratus) is a freshwater fish in the family Cyprinidae of order Cypriniformes. It is commonly kept as a pet in indoor aquariums, and is one of the most popular aquarium fish. Goldfish released into the wild have become an invasive pest in parts of North America.",
                            Name = "Goldfish",
                            PicturePath = "12017f59-9e39-4a6c-9153-66d83400e5ea_goldfish.jpg"
                        });
                });

            modelBuilder.Entity("PetShopProj.Models.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AnswerTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Answered")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CallTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Calls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Answered = false,
                            CallTime = new DateTime(2025, 4, 13, 20, 9, 46, 523, DateTimeKind.Utc).AddTicks(7403),
                            Email = "koliakovcr7@gmail.com",
                            Name = "Alon",
                            Problem = "Site too awesome!!"
                        });
                });

            modelBuilder.Entity("PetShopProj.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mammal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Birds"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Amphibians"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Reptiles"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Invertebrates"
                        });
                });

            modelBuilder.Entity("PetShopProj.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnimalId = 1,
                            Content = "woooow AS well"
                        },
                        new
                        {
                            Id = 2,
                            AnimalId = 2,
                            Content = "woooow"
                        },
                        new
                        {
                            Id = 3,
                            AnimalId = 3,
                            Content = "So cute"
                        },
                        new
                        {
                            Id = 4,
                            AnimalId = 3,
                            Content = "HAHAHA"
                        },
                        new
                        {
                            Id = 5,
                            AnimalId = 4,
                            Content = "LOL xD"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser<string>");

                    b.HasDiscriminator().HasValue("IdentityUser");
                });

            modelBuilder.Entity("PetShopProj.Models.Animal", b =>
                {
                    b.HasOne("PetShopProj.Models.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PetShopProj.Models.Comment", b =>
                {
                    b.HasOne("PetShopProj.Models.Animal", "Animal")
                        .WithMany("Comments")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("PetShopProj.Models.Animal", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("PetShopProj.Models.Category", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
