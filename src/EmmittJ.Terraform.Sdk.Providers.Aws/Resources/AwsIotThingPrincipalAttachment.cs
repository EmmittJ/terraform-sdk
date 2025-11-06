using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_principal_attachment resource.
/// </summary>
public class AwsIotThingPrincipalAttachment : TerraformResource
{
    public AwsIotThingPrincipalAttachment(string name) : base("aws_iot_thing_principal_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thing attribute.
    /// </summary>
    public string? Thing
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing")?.Value;
        set => this.WithProperty("thing", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thing_principal_type attribute.
    /// </summary>
    public string? ThingPrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_principal_type")?.Value;
        set => this.WithProperty("thing_principal_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
