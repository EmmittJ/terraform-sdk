using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_permission resource.
/// </summary>
public class AwsCloudwatchEventPermission : TerraformResource
{
    public AwsCloudwatchEventPermission(string name) : base("aws_cloudwatch_event_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventBusName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_bus_name");
        set => this.WithProperty("event_bus_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StatementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id");
        set => this.WithProperty("statement_id", value);
    }

}
