﻿
using Blog.Objects;
using FluentNHibernate.Mapping;

namespace Blog.Mappings
{
  public class PostMap: ClassMap<Post>
  {
    public PostMap()
    {
      Id(x => x.Id);
      Map(x => x.Title).Length(500).Not.Nullable();
      Map(x => x.Meta).Length(1000).Not.Nullable();
      Map(x => x.UrlSlug).Length(200).Not.Nullable();
      Map(x => x.Published).Not.Nullable();
      Map(x => x.PostedOn).Not.Nullable();
      Map(x => x.Modified);
      References(x => x.Category).Column("Category").Not.Nullable();
      HasManyToMany(x => x.Tags).Table("PostTagMap");
    }
  }
}
