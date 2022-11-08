using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;

namespace ShopeeApi.SeedData
{
    public class CategoryFoodSeed : IEntityTypeConfiguration<RelationCategoryFood>
    {
        public void Configure(EntityTypeBuilder<RelationCategoryFood> builder)
        {
            builder.HasData
            (
                new RelationCategoryFood
                {
                    CategoryId = 1,
                    FoodId = 1
                },

                new RelationCategoryFood
                {
                    CategoryId = 1,
                    FoodId = 2
                },

                new RelationCategoryFood
                {
                    CategoryId = 1,
                    FoodId = 3
                }

                ,

                new RelationCategoryFood
                {
                    CategoryId = 2,
                    FoodId = 4
                },

                 new RelationCategoryFood
                 {
                     CategoryId = 3,
                     FoodId = 5
                 },

                  new RelationCategoryFood
                  {
                      CategoryId = 3,
                      FoodId = 6
                  },

                   new RelationCategoryFood
                   {
                       CategoryId = 3,
                       FoodId = 7
                   },

                    new RelationCategoryFood
                    {
                        CategoryId = 3,
                        FoodId = 8
                    },

                     new RelationCategoryFood
                     {
                         CategoryId = 3,
                         FoodId = 9
                     },

                      new RelationCategoryFood
                      {
                          CategoryId = 3,
                          FoodId = 10
                      },

                       new RelationCategoryFood
                       {
                           CategoryId = 4,
                           FoodId = 11
                       },

                       new RelationCategoryFood
                       {
                           CategoryId = 4,
                           FoodId = 12
                       },

                       new RelationCategoryFood
                       {
                           CategoryId = 5,
                           FoodId = 13
                       },

                        new RelationCategoryFood
                        {
                            CategoryId = 5,
                            FoodId = 14
                        },

                         new RelationCategoryFood
                         {
                             CategoryId = 5,
                             FoodId = 15
                         },

                          new RelationCategoryFood
                          {
                              CategoryId = 5,
                              FoodId = 16
                          },

                           new RelationCategoryFood
                           {
                               CategoryId = 5,
                               FoodId = 17
                           },

                            new RelationCategoryFood
                            {
                                CategoryId = 5,
                                FoodId = 18
                            },

                             new RelationCategoryFood
                             {
                                 CategoryId = 6,
                                 FoodId = 19
                             },

                              new RelationCategoryFood
                              {
                                  CategoryId = 6,
                                  FoodId = 20
                              },

                                new RelationCategoryFood
                                {
                                    CategoryId = 6,
                                    FoodId = 21
                                },

                                  new RelationCategoryFood
                                  {
                                      CategoryId = 6,
                                      FoodId = 22
                                  },

                                    new RelationCategoryFood
                                    {
                                        CategoryId = 6,
                                        FoodId = 23
                                    },

                                      new RelationCategoryFood
                                      {
                                          CategoryId = 6,
                                          FoodId = 24
                                      },

                                        new RelationCategoryFood
                                        {
                                            CategoryId = 6,
                                            FoodId = 25
                                        },

                                          new RelationCategoryFood
                                          {
                                              CategoryId = 6,
                                              FoodId = 26
                                          },

                                            new RelationCategoryFood
                                            {
                                                CategoryId = 7,
                                                FoodId = 27
                                            },

                                             new RelationCategoryFood
                                             {
                                                 CategoryId = 7,
                                                 FoodId = 28
                                             },

                                              new RelationCategoryFood
                                              {
                                                  CategoryId = 7,
                                                  FoodId = 29
                                              },

                                               new RelationCategoryFood
                                               {
                                                   CategoryId = 8,
                                                   FoodId = 30
                                               },

                                                new RelationCategoryFood
                                                {
                                                    CategoryId = 8,
                                                    FoodId = 31
                                                },

                                                 new RelationCategoryFood
                                                 {
                                                     CategoryId = 8,
                                                     FoodId = 32
                                                 },

                                                  new RelationCategoryFood
                                                  {
                                                      CategoryId = 9,
                                                      FoodId = 33
                                                  },

                                                   new RelationCategoryFood
                                                   {
                                                       CategoryId = 9,
                                                       FoodId = 34
                                                   },

                                                    new RelationCategoryFood
                                                    {
                                                        CategoryId = 10,
                                                        FoodId = 35
                                                    },

                                                     new RelationCategoryFood
                                                     {
                                                         CategoryId = 10,
                                                         FoodId = 36
                                                     },

                                                      new RelationCategoryFood
                                                      {
                                                          CategoryId = 10,
                                                          FoodId = 37
                                                      },

new RelationCategoryFood
{
    CategoryId = 11,
    FoodId = 38
},

new RelationCategoryFood
{
    CategoryId = 11,
    FoodId = 39
},

new RelationCategoryFood
{
    CategoryId = 12,
    FoodId = 40
},

new RelationCategoryFood
{
    CategoryId = 12,
    FoodId = 41
},

new RelationCategoryFood
{
    CategoryId = 12,
    FoodId = 42
},

new RelationCategoryFood
{
    CategoryId = 12,
    FoodId = 43
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 44
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 45
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 46
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 47
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 48
},

new RelationCategoryFood
{
    CategoryId = 13,
    FoodId = 49
},

new RelationCategoryFood
{
    CategoryId = 14,
    FoodId = 50
},

new RelationCategoryFood
{
    CategoryId = 14,
    FoodId = 51
},

new RelationCategoryFood
{
    CategoryId = 15,
    FoodId = 52
},

new RelationCategoryFood
{
    CategoryId = 15,
    FoodId = 53
},

new RelationCategoryFood
{
    CategoryId = 15,
    FoodId = 54
},

new RelationCategoryFood
{
    CategoryId = 16,
    FoodId = 55
},

new RelationCategoryFood
{
    CategoryId = 16,
    FoodId = 56
},

new RelationCategoryFood
{
    CategoryId = 16,
    FoodId = 52
},

new RelationCategoryFood
{
    CategoryId = 17,
    FoodId = 55
},

new RelationCategoryFood
{
    CategoryId = 17,
    FoodId = 58
},

new RelationCategoryFood
{
    CategoryId = 17,
    FoodId = 59
},

new RelationCategoryFood
{
    CategoryId = 17,
    FoodId = 60
},

new RelationCategoryFood
{
    CategoryId = 18,
    FoodId = 61
},

new RelationCategoryFood
{
    CategoryId = 18,
    FoodId = 62
},

new RelationCategoryFood
{
    CategoryId = 19,
    FoodId = 63
},

new RelationCategoryFood
{
    CategoryId = 19,
    FoodId = 64
},

new RelationCategoryFood
{
    CategoryId = 20,
    FoodId = 57
},

new RelationCategoryFood
{
    CategoryId = 20,
    FoodId = 65
},

new RelationCategoryFood
{
    CategoryId = 20,
    FoodId = 56
},

new RelationCategoryFood
{
    CategoryId = 21,
    FoodId = 67
},

new RelationCategoryFood
{
    CategoryId = 21,
    FoodId = 68
},

new RelationCategoryFood
{
    CategoryId = 22,
    FoodId = 69
},

new RelationCategoryFood
{
    CategoryId = 22,
    FoodId = 70
},

new RelationCategoryFood
{
    CategoryId = 23,
    FoodId = 71
},

new RelationCategoryFood
{
    CategoryId = 23,
    FoodId = 72
},

new RelationCategoryFood
{
    CategoryId = 23,
    FoodId = 73
},

new RelationCategoryFood
{
    CategoryId = 23,
    FoodId = 74
},

new RelationCategoryFood
{
    CategoryId = 24,
    FoodId = 75
},

new RelationCategoryFood
{
    CategoryId = 24,
    FoodId = 76
},

new RelationCategoryFood
{
    CategoryId = 24,
    FoodId = 77
},

new RelationCategoryFood
{
    CategoryId = 25,
    FoodId = 78
},

new RelationCategoryFood
{
    CategoryId = 25,
    FoodId = 79
},

new RelationCategoryFood
{
    CategoryId = 25,
    FoodId = 80
},

new RelationCategoryFood
{
    CategoryId = 25,
    FoodId = 81
},

new RelationCategoryFood
{
    CategoryId = 26,
    FoodId = 82
},

new RelationCategoryFood
{
    CategoryId = 26,
    FoodId = 83
},

new RelationCategoryFood
{
    CategoryId = 26,
    FoodId = 84
},

new RelationCategoryFood
{
    CategoryId = 27,
    FoodId = 85
},

new RelationCategoryFood
{
    CategoryId = 27,
    FoodId = 87
},

new RelationCategoryFood
{
    CategoryId = 28,
    FoodId = 77
},

new RelationCategoryFood
{
    CategoryId = 28,
    FoodId = 85
},

new RelationCategoryFood
{
    CategoryId = 29,
    FoodId = 88
},

new RelationCategoryFood
{
    CategoryId = 29,
    FoodId = 89
},

new RelationCategoryFood
{
    CategoryId = 30,
    FoodId = 90
},

new RelationCategoryFood
{
    CategoryId = 31,
    FoodId = 91
},

new RelationCategoryFood
{
    CategoryId = 31,
    FoodId = 92
},

new RelationCategoryFood
{
    CategoryId = 31,
    FoodId = 93
},

new RelationCategoryFood
{
    CategoryId = 32,
    FoodId = 94
},

new RelationCategoryFood
{
    CategoryId = 32,
    FoodId = 95
},

new RelationCategoryFood
{
    CategoryId = 32,
    FoodId = 96
},

new RelationCategoryFood
{
    CategoryId = 32,
    FoodId = 97
},

new RelationCategoryFood
{
    CategoryId = 32,
    FoodId = 98
},

new RelationCategoryFood
{
    CategoryId = 33,
    FoodId = 99
},

new RelationCategoryFood
{
    CategoryId = 33,
    FoodId = 100
},

new RelationCategoryFood
{
    CategoryId = 33,
    FoodId = 101
},

new RelationCategoryFood
{
    CategoryId = 33,
    FoodId = 102
},

new RelationCategoryFood
{
    CategoryId = 34,
    FoodId = 103
},

new RelationCategoryFood
{
    CategoryId = 35,
    FoodId = 104
},

new RelationCategoryFood
{
    CategoryId = 36,
    FoodId = 105
},

new RelationCategoryFood
{
    CategoryId = 36,
    FoodId = 106
},

new RelationCategoryFood
{
    CategoryId = 37,
    FoodId = 107
},

new RelationCategoryFood
{
    CategoryId = 37,
    FoodId = 108
},

new RelationCategoryFood
{
    CategoryId = 38,
    FoodId = 109
},

new RelationCategoryFood
{
    CategoryId = 38,
    FoodId = 110
},

new RelationCategoryFood
{
    CategoryId = 38,
    FoodId = 111
},

new RelationCategoryFood
{
    CategoryId = 39,
    FoodId = 112
},

new RelationCategoryFood
{
    CategoryId = 39,
    FoodId = 113
},

new RelationCategoryFood
{
    CategoryId = 39,
    FoodId = 114
},

new RelationCategoryFood
{
    CategoryId = 40,
    FoodId = 115
},

new RelationCategoryFood
{
    CategoryId = 40,
    FoodId = 116
},

new RelationCategoryFood
{
    CategoryId = 40,
    FoodId = 117
},

new RelationCategoryFood
{
    CategoryId = 41,
    FoodId = 118
},

new RelationCategoryFood
{
    CategoryId = 41,
    FoodId = 119
},

new RelationCategoryFood
{
    CategoryId = 42,
    FoodId = 120
},

new RelationCategoryFood
{
    CategoryId = 43,
    FoodId = 121
},

new RelationCategoryFood
{
    CategoryId = 44,
    FoodId = 122
},

new RelationCategoryFood
{
    CategoryId = 45,
    FoodId = 123
},

new RelationCategoryFood
{
    CategoryId = 46,
    FoodId = 124
},

new RelationCategoryFood
{
    CategoryId = 47,
    FoodId = 125
},

new RelationCategoryFood
{
    CategoryId = 48,
    FoodId = 126
},

new RelationCategoryFood
{
    CategoryId = 49,
    FoodId = 127
},

new RelationCategoryFood
{
    CategoryId = 50,
    FoodId = 128
},

new RelationCategoryFood
{
    CategoryId = 51,
    FoodId = 129
},

new RelationCategoryFood
{
    CategoryId = 51,
    FoodId = 130
},

new RelationCategoryFood
{
    CategoryId = 52,
    FoodId = 131
},

new RelationCategoryFood
{
    CategoryId = 52,
    FoodId = 132
},

new RelationCategoryFood
{
    CategoryId = 53,
    FoodId = 133
},

new RelationCategoryFood
{
    CategoryId = 53,
    FoodId = 134
},

new RelationCategoryFood
{
    CategoryId = 54,
    FoodId = 135
},

new RelationCategoryFood
{
    CategoryId = 54,
    FoodId = 136
},

new RelationCategoryFood
{
    CategoryId = 54,
    FoodId = 137
}
            );
        }
    }
}