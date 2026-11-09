from setuptools import setup, find_packages

setup(
    name='apiverve_unitconverter',
    version='1.2.5',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Unit Converter converts values between 185 units across 23 measures, from length, mass and volume to speed, pressure, data size, energy and electrical units. Pass a numeric value with source and target unit codes to get the converted result and unit abbreviations. On paid plans, precision sets the decimal places and conversions=true adds the value in every unit of the same measure.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/unitconverter?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)
