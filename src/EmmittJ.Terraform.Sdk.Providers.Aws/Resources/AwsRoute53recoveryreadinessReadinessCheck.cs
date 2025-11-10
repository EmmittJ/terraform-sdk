using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_route53recoveryreadiness_readiness_check resource.
/// </summary>
public class AwsRoute53recoveryreadinessReadinessCheck : TerraformResource
{
    public AwsRoute53recoveryreadinessReadinessCheck(string name) : base("aws_route53recoveryreadiness_readiness_check", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The readiness_check_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheckName is required")]
    public required TerraformProperty<string> ReadinessCheckName
    {
        get => GetProperty<TerraformProperty<string>>("readiness_check_name");
        set => this.WithProperty("readiness_check_name", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformProperty<string> ResourceSetName
    {
        get => GetProperty<TerraformProperty<string>>("resource_set_name");
        set => this.WithProperty("resource_set_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
