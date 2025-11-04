using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_plan.
/// </summary>
public class AwsSsmcontactsPlanDataSource : TerraformDataSource
{
    public AwsSsmcontactsPlanDataSource(string name) : base("aws_ssmcontacts_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("stage");
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    public string? ContactId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_id")?.Value;
        set => this.WithProperty("contact_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stage attribute.
    /// </summary>
    public TerraformExpression Stage => this["stage"];

}
