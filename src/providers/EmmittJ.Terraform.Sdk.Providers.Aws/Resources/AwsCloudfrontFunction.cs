using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_function Terraform resource.
/// Manages a aws_cloudfront_function resource.
/// </summary>
public partial class AwsCloudfrontFunction(string name) : TerraformResource("aws_cloudfront_function", name)
{
    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => GetRequiredArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
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
    /// The key_value_store_associations attribute.
    /// </summary>
    public TerraformSet<string>? KeyValueStoreAssociations
    {
        get => GetArgument<TerraformSet<string>>("key_value_store_associations");
        set => SetArgument("key_value_store_associations", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformValue<bool>? Publish
    {
        get => GetArgument<TerraformValue<bool>>("publish");
        set => SetArgument("publish", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => GetRequiredArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The live_stage_etag attribute.
    /// </summary>
    public TerraformValue<string> LiveStageEtag
        => AsReference("live_stage_etag");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
