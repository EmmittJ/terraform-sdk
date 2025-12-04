using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogOrganizationsAccess.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogOrganizationsAccessTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_organizations_access Terraform resource.
/// Manages a aws_servicecatalog_organizations_access resource.
/// </summary>
public partial class AwsServicecatalogOrganizationsAccess(string name) : TerraformResource("aws_servicecatalog_organizations_access", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogOrganizationsAccessTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogOrganizationsAccessTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
