using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for parameter in AzureadSynchronizationJobProvisionOnDemand.
/// Nesting mode: list
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemandParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The identifier of the synchronization rule to be applied. This rule ID is defined in the schema for a given synchronization job or template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformValue<string> RuleId
    {
        get => new TerraformReference<string>(this, "rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// Subject block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    public required TerraformList<AzureadSynchronizationJobProvisionOnDemandParameterBlockSubjectBlock> Subject
    {
        get => GetRequiredArgument<TerraformList<AzureadSynchronizationJobProvisionOnDemandParameterBlockSubjectBlock>>("subject");
        set => SetArgument("subject", value);
    }

}

/// <summary>
/// Block type for subject in AzureadSynchronizationJobProvisionOnDemandParameterBlock.
/// Nesting mode: list
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemandParameterBlockSubjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject";

    /// <summary>
    /// The identifier of an object to which a synchronization job is to be applied. Can be one of the following: (1) An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD. (2) The user ID for synchronization from Azure AD to a third-party. (3) The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Azure AD.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The type of the object to which a synchronization job is to be applied. Can be one of the following: `user` for synchronizing between Active Directory and Azure AD, `User` for synchronizing a user between Azure AD and a third-party application, `Worker` for synchronization a user between Workday and either Active Directory or Azure AD, `Group` for synchronizing a group between Azure AD and a third-party application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectTypeName is required")]
    public required TerraformValue<string> ObjectTypeName
    {
        get => new TerraformReference<string>(this, "object_type_name");
        set => SetArgument("object_type_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadSynchronizationJobProvisionOnDemand.
/// Nesting mode: single
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_synchronization_job_provision_on_demand Terraform resource.
/// Manages a azuread_synchronization_job_provision_on_demand resource.
/// </summary>
public partial class AzureadSynchronizationJobProvisionOnDemand(string name) : TerraformResource("azuread_synchronization_job_provision_on_demand", name)
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
    /// The object ID of the service principal for which this synchronization job should be provisioned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => new TerraformReference<string>(this, "service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

    /// <summary>
    /// The identifier for the synchronization jop.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynchronizationJobId is required")]
    public required TerraformValue<string> SynchronizationJobId
    {
        get => new TerraformReference<string>(this, "synchronization_job_id");
        set => SetArgument("synchronization_job_id", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string>? Triggers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "triggers").ResolveNodes(ctx));
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameter block(s) required")]
    public required TerraformList<AzureadSynchronizationJobProvisionOnDemandParameterBlock> Parameter
    {
        get => GetRequiredArgument<TerraformList<AzureadSynchronizationJobProvisionOnDemandParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
