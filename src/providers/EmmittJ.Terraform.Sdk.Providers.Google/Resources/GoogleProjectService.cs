using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleProjectService.
/// Nesting mode: single
/// </summary>
public class GoogleProjectServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_project_service Terraform resource.
/// Manages a google_project_service resource.
/// </summary>
public partial class GoogleProjectService(string name) : TerraformResource("google_project_service", name)
{
    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public TerraformValue<bool>? DisableDependentServices
    {
        get => GetArgument<TerraformValue<bool>>("disable_dependent_services");
        set => SetArgument("disable_dependent_services", value);
    }

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? DisableOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("disable_on_destroy");
        set => SetArgument("disable_on_destroy", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleProjectServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleProjectServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
