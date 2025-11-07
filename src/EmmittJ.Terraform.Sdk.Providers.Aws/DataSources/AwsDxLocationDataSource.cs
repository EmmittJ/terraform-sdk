using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_location.
/// </summary>
public class AwsDxLocationDataSource : TerraformDataSource
{
    public AwsDxLocationDataSource(string name) : base("aws_dx_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_macsec_port_speeds");
        this.DeclareOutput("available_port_speeds");
        this.DeclareOutput("available_providers");
        this.DeclareOutput("location_name");
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
    /// The location_code attribute.
    /// </summary>
    public TerraformProperty<string>? LocationCode
    {
        get => GetProperty<TerraformProperty<string>>("location_code");
        set => this.WithProperty("location_code", value);
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
    /// The available_macsec_port_speeds attribute.
    /// </summary>
    public TerraformExpression AvailableMacsecPortSpeeds => this["available_macsec_port_speeds"];

    /// <summary>
    /// The available_port_speeds attribute.
    /// </summary>
    public TerraformExpression AvailablePortSpeeds => this["available_port_speeds"];

    /// <summary>
    /// The available_providers attribute.
    /// </summary>
    public TerraformExpression AvailableProviders => this["available_providers"];

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    public TerraformExpression LocationName => this["location_name"];

}
