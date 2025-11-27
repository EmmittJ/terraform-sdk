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
        get => new TerraformReference<string>(this, "code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    public TerraformSet<string>? KeyValueStoreAssociations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "key_value_store_associations").ResolveNodes(ctx));
        set => SetArgument("key_value_store_associations", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformValue<bool>? Publish
    {
        get => new TerraformReference<bool>(this, "publish");
        set => SetArgument("publish", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The live_stage_etag attribute.
    /// </summary>
    public TerraformValue<string> LiveStageEtag
    {
        get => new TerraformReference<string>(this, "live_stage_etag");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
