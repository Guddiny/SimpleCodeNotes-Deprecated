﻿using SimpleCodeNotes.DataAccess.DTO;

namespace SimpleCodeNotes.DataAccess.Dto
{
    public class MetadataDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Workspace { get; set; } = string.Empty;

        public string Syntax { get; set; } = string.Empty;

        public List<string> Tags { get; set; } = new();
    }
}