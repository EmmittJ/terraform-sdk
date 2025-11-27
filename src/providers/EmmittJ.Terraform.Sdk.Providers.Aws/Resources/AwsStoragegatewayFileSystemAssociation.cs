using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in AwsStoragegatewayFileSystemAssociation.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayFileSystemAssociationCacheAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_attributes";

    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? CacheStaleTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "cache_stale_timeout_in_seconds");
        set => SetArgument("cache_stale_timeout_in_seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsStoragegatewayFileSystemAssociation.
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayFileSystemAssociationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_storagegateway_file_system_association Terraform resource.
/// Manages a aws_storagegateway_file_system_association resource.
/// </summary>
public partial class AwsStoragegatewayFileSystemAssociation(string name) : TerraformResource("aws_storagegateway_file_system_association", name)
{
    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    public TerraformValue<string>? AuditDestinationArn
    {
        get => new TerraformReference<string>(this, "audit_destination_arn");
        set => SetArgument("audit_destination_arn", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => new TerraformReference<string>(this, "gateway_arn");
        set => SetArgument("gateway_arn", value);
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
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    public required TerraformValue<string> LocationArn
    {
        get => new TerraformReference<string>(this, "location_arn");
        set => SetArgument("location_arn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CacheAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    public TerraformList<AwsStoragegatewayFileSystemAssociationCacheAttributesBlock>? CacheAttributes
    {
        get => GetArgument<TerraformList<AwsStoragegatewayFileSystemAssociationCacheAttributesBlock>>("cache_attributes");
        set => SetArgument("cache_attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsStoragegatewayFileSystemAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsStoragegatewayFileSystemAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
