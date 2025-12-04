using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_function Terraform data source.
/// Retrieves information about a aws_cloudfront_function.
/// </summary>
public partial class AwsCloudfrontFunctionDataSource(string name) : TerraformDataSource("aws_cloudfront_function", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformValue<string> Stage
    {
        get => GetArgument<TerraformValue<string>>("stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformValue<string> Code
        => AsReference("code");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
        => AsReference("comment");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    public TerraformSet<string> KeyValueStoreAssociations
        => AsReference("key_value_store_associations");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => AsReference("last_modified_time");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string> Runtime
        => AsReference("runtime");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
