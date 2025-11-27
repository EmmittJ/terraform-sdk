using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshVirtualRouter.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualRouterSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// Listener block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualRouterSpecBlockListenerBlock>? Listener
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualRouterSpecBlockListenerBlock>>("listener");
        set => SetArgument("listener", value);
    }

}

/// <summary>
/// Block type for listener in AwsAppmeshVirtualRouterSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualRouterSpecBlockListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "listener";

    /// <summary>
    /// PortMapping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortMapping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortMapping block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualRouterSpecBlockListenerBlockPortMappingBlock> PortMapping
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualRouterSpecBlockListenerBlockPortMappingBlock>>("port_mapping");
        set => SetArgument("port_mapping", value);
    }

}

/// <summary>
/// Block type for port_mapping in AwsAppmeshVirtualRouterSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualRouterSpecBlockListenerBlockPortMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_mapping";

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_virtual_router Terraform resource.
/// Manages a aws_appmesh_virtual_router resource.
/// </summary>
public partial class AwsAppmeshVirtualRouter(string name) : TerraformResource("aws_appmesh_virtual_router", name)
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
    /// The mesh_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    public required TerraformValue<string> MeshName
    {
        get => new TerraformReference<string>(this, "mesh_name");
        set => SetArgument("mesh_name", value);
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string> MeshOwner
    {
        get => new TerraformReference<string>(this, "mesh_owner");
        set => SetArgument("mesh_owner", value);
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
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
    {
        get => new TerraformReference<string>(this, "resource_owner");
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualRouterSpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualRouterSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
