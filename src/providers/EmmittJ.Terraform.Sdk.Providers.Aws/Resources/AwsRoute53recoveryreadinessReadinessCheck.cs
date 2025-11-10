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
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("readiness_check_name");
        SetOutput("resource_set_name");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The readiness_check_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheckName is required")]
    public required TerraformProperty<string> ReadinessCheckName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("readiness_check_name");
        set => SetProperty("readiness_check_name", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformProperty<string> ResourceSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_set_name");
        set => SetProperty("resource_set_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessReadinessCheckTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
