using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudGatewayCustomDomain.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayCustomDomainTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_spring_cloud_gateway_custom_domain Terraform resource.
/// Manages a azurerm_spring_cloud_gateway_custom_domain resource.
/// </summary>
public partial class AzurermSpringCloudGatewayCustomDomain(string name) : TerraformResource("azurerm_spring_cloud_gateway_custom_domain", name)
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
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    public required TerraformValue<string> SpringCloudGatewayId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_gateway_id");
        set => SetArgument("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? Thumbprint
    {
        get => GetArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudGatewayCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudGatewayCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
