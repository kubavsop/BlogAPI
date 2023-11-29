﻿using Blog.API.Controllers.Dto.Responses;
using Blog.API.Entities.Database;

namespace Blog.API.Common.Mappers;

internal static class TagMapper
{
    public static IEnumerable<TagDto> TagsToTagsDto(IEnumerable<Tag> tags)
    {
        return tags.Select(TagToTagDto);
    }
    
    private static TagDto TagToTagDto(Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            CreateTime = tag.CreateTime,
            Name = tag.Name
        };
    }
}