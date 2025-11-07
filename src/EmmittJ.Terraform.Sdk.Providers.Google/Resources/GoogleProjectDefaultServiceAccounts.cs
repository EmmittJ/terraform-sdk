using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_default_service_accounts resource.
/// </summary>
public class GoogleProjectDefaultServiceAccounts : TerraformResource
{
    public GoogleProjectDefaultServiceAccounts(string name) : base("google_project_default_service_accounts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("service_accounts");
    }

    /// <summary>
    /// The action to be performed in the default service accounts. Valid values are: DEPRIVILEGE, DELETE, DISABLE.
    /// 				Note that DEPRIVILEGE action will ignore the REVERT configuration in the restore_policy.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project ID where service accounts are created.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The action to be performed in the default service accounts on the resource destroy.
    /// 				Valid values are NONE, REVERT and REVERT_AND_IGNORE_FAILURE. It is applied for any action but in the DEPRIVILEGE.
    /// </summary>
    public TerraformProperty<string>? RestorePolicy
    {
        get => GetProperty<TerraformProperty<string>>("restore_policy");
        set => this.WithProperty("restore_policy", value);
    }

    /// <summary>
    /// The Service Accounts changed by this resource. It is used for revert the action on the destroy.
    /// </summary>
    public TerraformExpression ServiceAccounts => this["service_accounts"];

}
