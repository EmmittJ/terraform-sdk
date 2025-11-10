using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock : TerraformBlock
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
/// Manages a aws_route53recoveryreadiness_recovery_group resource.
/// </summary>
public class AwsRoute53recoveryreadinessRecoveryGroup : TerraformResource
{
    public AwsRoute53recoveryreadinessRecoveryGroup(string name) : base("aws_route53recoveryreadiness_recovery_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cells");
        SetOutput("id");
        SetOutput("recovery_group_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public List<TerraformProperty<string>> Cells
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cells");
        set => SetProperty("cells", value);
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
    /// The recovery_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryGroupName is required")]
    public required TerraformProperty<string> RecoveryGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_group_name");
        set => SetProperty("recovery_group_name", value);
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
    public AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
