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
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("ip_preference");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => AsReference("last_updated_date");

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string> MeshOwner
        => AsReference("mesh_owner");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
        => AsReference("resource_owner");

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
