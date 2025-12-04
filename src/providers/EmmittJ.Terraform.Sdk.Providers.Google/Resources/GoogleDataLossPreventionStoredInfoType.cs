using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dictionary in GoogleDataLossPreventionStoredInfoType.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dictionary";

    /// <summary>
    /// CloudStoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlockCloudStoragePathBlock>? CloudStoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlockCloudStoragePathBlock>>("cloud_storage_path");
        set => SetArgument("cloud_storage_path", value);
    }

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for cloud_storage_path in GoogleDataLossPreventionStoredInfoTypeDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeDictionaryBlockCloudStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionStoredInfoTypeDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeDictionaryBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}


/// <summary>
/// Block type for large_custom_dictionary in GoogleDataLossPreventionStoredInfoType.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "large_custom_dictionary";

    /// <summary>
    /// BigQueryField block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQueryField block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlock>? BigQueryField
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlock>>("big_query_field");
        set => SetArgument("big_query_field", value);
    }

    /// <summary>
    /// CloudStorageFileSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageFileSet block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockCloudStorageFileSetBlock>? CloudStorageFileSet
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockCloudStorageFileSetBlock>>("cloud_storage_file_set");
        set => SetArgument("cloud_storage_file_set", value);
    }

    /// <summary>
    /// OutputPath block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputPath is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputPath block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputPath block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockOutputPathBlock> OutputPath
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockOutputPathBlock>>("output_path");
        set => SetArgument("output_path", value);
    }

}

/// <summary>
/// Block type for big_query_field in GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query_field";

    /// <summary>
    /// Field block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Field block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Field block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockFieldBlock> Field
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockFieldBlock>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Table block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockTableBlock> Table
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockTableBlock>>("table");
        set => SetArgument("table", value);
    }

}

/// <summary>
/// Block type for field in GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for table in GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockBigQueryFieldBlockTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table";

    /// <summary>
    /// The dataset ID of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The Google Cloud Platform project ID of the project containing the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for cloud_storage_file_set in GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockCloudStorageFileSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_file_set";

    /// <summary>
    /// The url, in the format &#39;gs://&amp;lt;bucket&amp;gt;/&amp;lt;path&amp;gt;&#39;. Trailing wildcard in the path is allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for output_path in GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlockOutputPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for regex in GoogleDataLossPreventionStoredInfoType.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataLossPreventionStoredInfoType.
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_loss_prevention_stored_info_type Terraform resource.
/// Manages a google_data_loss_prevention_stored_info_type resource.
/// </summary>
public partial class GoogleDataLossPreventionStoredInfoType(string name) : TerraformResource("google_data_loss_prevention_stored_info_type", name)
{
    /// <summary>
    /// A description of the info type.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User set display name of the info type.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent of the info type in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformValue<string> StoredInfoTypeId
    {
        get => GetArgument<TerraformValue<string>>("stored_info_type_id") ?? AsReference("stored_info_type_id");
        set => SetArgument("stored_info_type_id", value);
    }

    /// <summary>
    /// The resource name of the info type. Set by the server.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Dictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlock>? Dictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeDictionaryBlock>>("dictionary");
        set => SetArgument("dictionary", value);
    }

    /// <summary>
    /// LargeCustomDictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LargeCustomDictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock>? LargeCustomDictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeLargeCustomDictionaryBlock>>("large_custom_dictionary");
        set => SetArgument("large_custom_dictionary", value);
    }

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionStoredInfoTypeRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionStoredInfoTypeRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataLossPreventionStoredInfoTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
