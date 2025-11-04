using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssmcontacts_plan resource.
/// </summary>
public class AwsSsmcontactsPlan : TerraformResource
{
    public AwsSsmcontactsPlan(string name) : base("aws_ssmcontacts_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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

}
