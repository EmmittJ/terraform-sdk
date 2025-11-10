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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DurationSeconds
    {
        get => GetProperty<TerraformProperty<double>>("duration_seconds");
        set => this.WithProperty("duration_seconds", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The managed_policy_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ManagedPolicyArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("managed_policy_arns");
        set => this.WithProperty("managed_policy_arns", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The require_instance_properties attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireInstanceProperties
    {
        get => GetProperty<TerraformProperty<bool>>("require_instance_properties");
        set => this.WithProperty("require_instance_properties", value);
    }

    /// <summary>
    /// The role_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RoleArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("role_arns");
        set => this.WithProperty("role_arns", value);
    }

    /// <summary>
    /// The session_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SessionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("session_policy");
        set => this.WithProperty("session_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
