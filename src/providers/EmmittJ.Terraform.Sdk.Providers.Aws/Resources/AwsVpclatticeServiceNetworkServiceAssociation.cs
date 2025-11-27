using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpclatticeServiceNetworkServiceAssociation.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpclattice_service_network_service_association Terraform resource.
/// Manages a aws_vpclattice_service_network_service_association resource.
/// </summary>
public partial class AwsVpclatticeServiceNetworkServiceAssociation(string name) : TerraformResource("aws_vpclattice_service_network_service_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The service_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceIdentifier is required")]
    public required TerraformValue<string> ServiceIdentifier
    {
        get => new TerraformReference<string>(this, "service_identifier");
        set => SetArgument("service_identifier", value);
    }

    /// <summary>
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    public required TerraformValue<string> ServiceNetworkIdentifier
    {
        get => new TerraformReference<string>(this, "service_network_identifier");
        set => SetArgument("service_network_identifier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainName
    {
        get => new TerraformReference<string>(this, "custom_domain_name");
    }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_entry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
