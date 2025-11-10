using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_result_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for payment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipPaymentConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public class AwsCleanroomsMembership : TerraformResource
{
    public AwsCleanroomsMembership(string name) : base("aws_cleanrooms_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("collaboration_arn");
        this.WithOutput("collaboration_creator_account_id");
        this.WithOutput("collaboration_creator_display_name");
        this.WithOutput("collaboration_name");
        this.WithOutput("create_time");
        this.WithOutput("id");
        this.WithOutput("member_abilities");
        this.WithOutput("status");
        this.WithOutput("tags_all");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationId is required")]
    public required TerraformProperty<string> CollaborationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("collaboration_id");
        set => this.WithProperty("collaboration_id", value);
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    public required TerraformProperty<string> QueryLogStatus
    {
        get => GetRequiredProperty<TerraformProperty<string>>("query_log_status");
        set => this.WithProperty("query_log_status", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// Block for default_result_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCleanroomsMembershipDefaultResultConfigurationBlock>? DefaultResultConfiguration
    {
        get => GetProperty<List<AwsCleanroomsMembershipDefaultResultConfigurationBlock>>("default_result_configuration");
        set => this.WithProperty("default_result_configuration", value);
    }

    /// <summary>
    /// Block for payment_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCleanroomsMembershipPaymentConfigurationBlock>? PaymentConfiguration
    {
        get => GetProperty<List<AwsCleanroomsMembershipPaymentConfigurationBlock>>("payment_configuration");
        set => this.WithProperty("payment_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    public TerraformExpression CollaborationArn => this["collaboration_arn"];

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    public TerraformExpression CollaborationCreatorAccountId => this["collaboration_creator_account_id"];

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    public TerraformExpression CollaborationCreatorDisplayName => this["collaboration_creator_display_name"];

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    public TerraformExpression CollaborationName => this["collaboration_name"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    public TerraformExpression MemberAbilities => this["member_abilities"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
