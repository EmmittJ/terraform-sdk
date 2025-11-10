using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rolesanywhere_profile resource.
/// </summary>
public class AwsRolesanywhereProfile : TerraformResource
{
    public AwsRolesanywhereProfile(string name) : base("aws_rolesanywhere_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("duration_seconds");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("managed_policy_arns");
        SetOutput("name");
        SetOutput("require_instance_properties");
        SetOutput("role_arns");
        SetOutput("session_policy");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DurationSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration_seconds");
        set => SetProperty("duration_seconds", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ManagedPolicyArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("managed_policy_arns");
        set => SetProperty("managed_policy_arns", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The require_instance_properties attribute.
    /// </summary>
    public TerraformProperty<bool> RequireInstanceProperties
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_instance_properties");
        set => SetProperty("require_instance_properties", value);
    }

    /// <summary>
    /// The role_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RoleArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("role_arns");
        set => SetProperty("role_arns", value);
    }

    /// <summary>
    /// The session_policy attribute.
    /// </summary>
    public TerraformProperty<string> SessionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("session_policy");
        set => SetProperty("session_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
