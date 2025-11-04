using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_synthetics_group_association resource.
/// </summary>
public class AwsSyntheticsGroupAssociation : TerraformResource
{
    public AwsSyntheticsGroupAssociation(string name) : base("aws_synthetics_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("group_arn");
        this.DeclareOutput("group_id");
    }

    /// <summary>
    /// The canary_arn attribute.
    /// </summary>
    public string? CanaryArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("canary_arn")?.Value;
        set => this.WithProperty("canary_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_arn attribute.
    /// </summary>
    public TerraformExpression GroupArn => this["group_arn"];

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformExpression GroupId => this["group_id"];

}
