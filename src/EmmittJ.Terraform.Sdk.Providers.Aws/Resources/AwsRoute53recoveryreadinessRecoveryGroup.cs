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
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Cells
    {
        get => GetProperty<List<TerraformProperty<string>>>("cells");
        set => this.WithProperty("cells", value);
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
    /// The recovery_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryGroupName is required")]
    public required TerraformProperty<string> RecoveryGroupName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_group_name");
        set => this.WithProperty("recovery_group_name", value);
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
    public AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
