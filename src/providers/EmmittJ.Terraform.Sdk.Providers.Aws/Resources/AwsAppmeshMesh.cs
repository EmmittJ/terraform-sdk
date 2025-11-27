using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshMesh.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshMeshSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// EgressFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFilter block(s) allowed")]
    public TerraformList<AwsAppmeshMeshSpecBlockEgressFilterBlock>? EgressFilter
    {
        get => GetArgument<TerraformList<AwsAppmeshMeshSpecBlockEgressFilterBlock>>("egress_filter");
        set => SetArgument("egress_filter", value);
    }

    /// <summary>
    /// ServiceDiscovery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    public TerraformList<AwsAppmeshMeshSpecBlockServiceDiscoveryBlock>? ServiceDiscovery
    {
        get => GetArgument<TerraformList<AwsAppmeshMeshSpecBlockServiceDiscoveryBlock>>("service_discovery");
        set => SetArgument("service_discovery", value);
    }

}

/// <summary>
/// Block type for egress_filter in AwsAppmeshMeshSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshMeshSpecBlockEgressFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_filter";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for service_discovery in AwsAppmeshMeshSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshMeshSpecBlockServiceDiscoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_discovery";

    /// <summary>
    /// The ip_preference attribute.
    /// </summary>
    public TerraformValue<string>? IpPreference
    {
        get => new TerraformReference<string>(this, "ip_preference");
        set => SetArgument("ip_preference", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_mesh Terraform resource.
/// Manages a aws_appmesh_mesh resource.
/// </summary>
public partial class AwsAppmeshMesh(string name) : TerraformResource("aws_appmesh_mesh", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string> MeshOwner
    {
        get => new TerraformReference<string>(this, "mesh_owner");
    }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
    {
        get => new TerraformReference<string>(this, "resource_owner");
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<AwsAppmeshMeshSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<AwsAppmeshMeshSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
