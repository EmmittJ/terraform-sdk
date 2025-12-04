using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshVirtualService.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualServiceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// ProviderAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProviderAttribute block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlock>? ProviderAttribute
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlock>>("provider");
        set => SetArgument("provider", value);
    }

}

/// <summary>
/// Block type for provider in AwsAppmeshVirtualServiceSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider";

    /// <summary>
    /// VirtualNode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNode block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualNodeBlock>? VirtualNode
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualNodeBlock>>("virtual_node");
        set => SetArgument("virtual_node", value);
    }

    /// <summary>
    /// VirtualRouter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRouter block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualRouterBlock>? VirtualRouter
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualRouterBlock>>("virtual_router");
        set => SetArgument("virtual_router", value);
    }

}

/// <summary>
/// Block type for virtual_node in AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_node";

    /// <summary>
    /// The virtual_node_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNodeName is required")]
    public required TerraformValue<string> VirtualNodeName
    {
        get => GetArgument<TerraformValue<string>>("virtual_node_name");
        set => SetArgument("virtual_node_name", value);
    }

}

/// <summary>
/// Block type for virtual_router in AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualServiceSpecBlockProviderAttributeBlockVirtualRouterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_router";

    /// <summary>
    /// The virtual_router_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualRouterName is required")]
    public required TerraformValue<string> VirtualRouterName
    {
        get => GetArgument<TerraformValue<string>>("virtual_router_name");
        set => SetArgument("virtual_router_name", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_virtual_service Terraform resource.
/// Manages a aws_appmesh_virtual_service resource.
/// </summary>
public partial class AwsAppmeshVirtualService(string name) : TerraformResource("aws_appmesh_virtual_service", name)
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
    /// The mesh_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    public required TerraformValue<string> MeshName
    {
        get => GetArgument<TerraformValue<string>>("mesh_name");
        set => SetArgument("mesh_name", value);
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string>? MeshOwner
    {
        get => GetArgument<TerraformValue<string>>("mesh_owner");
        set => SetArgument("mesh_owner", value);
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
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
        => AsReference("resource_owner");

    /// <summary>
    /// Spec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualServiceSpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualServiceSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
